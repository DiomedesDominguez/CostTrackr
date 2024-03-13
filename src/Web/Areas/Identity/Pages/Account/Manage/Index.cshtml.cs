using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.DataAccess.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using DNMOFT.CostTrackr.Web.Helpers;

namespace DNMOFT.CostTrackr.Web.Areas.Identity.Pages.Account.Manage;

#pragma warning disable CS8601
#pragma warning disable CS8618
public class IndexModel : PageModel
{
    private readonly UserManager<mUser> _userManager;
    private readonly SignInManager<mUser> _signInManager;
    private readonly IDistributedCache _distributedCache;

    public IndexModel(
        UserManager<mUser> userManager,
        SignInManager<mUser> signInManager,
        IDistributedCache distributedCache)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _distributedCache = distributedCache;
    }

    /// <summary>
    ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    [TempData]
    public string StatusMessage { get; set; }

    /// <summary>
    ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    [BindProperty]
    public InputModel Input { get; set; }

    /// <summary>
    ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public class InputModel
    {
        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }

    private async Task LoadAsync(mUser user)
    {
        const string emailKey = "userEmail";
        const string phoneNumberKey = "phoneNumber";
        const string userNameKey = "userName";

        Username = await _distributedCache.GetRecordAsync<string>(emailKey);

        if (Username == string.Empty || Username == null)
        {
            Username = user.UserName;
            await _distributedCache.SetRecordAsync(emailKey, Username);
            await _distributedCache.SetRecordAsync(userNameKey, user.Name);
        }

        var phoneNumber = await _distributedCache.GetRecordAsync<string>(phoneNumberKey);
        if (phoneNumber == null || phoneNumber == string.Empty)
        {
            phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            await _distributedCache.SetRecordAsync(phoneNumberKey, phoneNumber);
        }

        Input = new InputModel
        {
            PhoneNumber = phoneNumber
        };
    }

    public async Task<IActionResult> OnGetAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        await LoadAsync(user);
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        if (!ModelState.IsValid)
        {
            await LoadAsync(user);
            return Page();
        }

        var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
        if (Input.PhoneNumber != phoneNumber)
        {
            var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
            if (!setPhoneResult.Succeeded)
            {
                StatusMessage = "Unexpected error when trying to set phone number.";
                return RedirectToPage();
            }
        }

        await _signInManager.RefreshSignInAsync(user);
        StatusMessage = "Your profile has been updated";
        return RedirectToPage();
    }
}

#pragma warning restore CS8618
#pragma warning restore CS8601