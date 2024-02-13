using System;
using System.Collections.Generic;
using DNMOFT.CostTrackr.DataAccess.Enums;

namespace DNMOFT.CostTrackr.DataAccess.Interfaces;
/// <summary>
/// Represents the base entity interface.
/// </summary>
public interface IBaseEntity : IDisposable
{
    /// <summary>
    /// Gets or sets the client IP address.
    /// </summary>
    string ClientIp { get; set; }

    /// <summary>
    /// Gets or sets the creation date and time.
    /// </summary>
    DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who created the entity.
    /// </summary>
    long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the record state.
    /// </summary>
    RecordState RecordState { get; set; }

    /// <summary>
    /// Gets or sets the ID of the entity.
    /// </summary>
    long Id { get; set; }

    /// <summary>
    /// Gets or sets the last modified date and time.
    /// </summary>
    DateTime LastModifiedAt { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who last modified the entity.
    /// </summary>
    long LastModifiedBy { get; set; }

    /// <summary>
    /// Gets or sets the ID of the branch office.
    /// </summary>
    long SucursalId { get; set; }
}