namespace DNMOFT.CostTrackr.ViewModel.Interfaces;

 using System;

    public interface IBaseViewModel
    {
        long Id { get; set; }
        byte EstadoRegistro { get; set; }
        DateTime LastModifiedAt { get; set; }
    }
