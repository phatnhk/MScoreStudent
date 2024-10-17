﻿namespace MScoreStudent.Domain.Auditable
{
    public interface IAuditableBaseEntity : IBaseEntity
    {
        string CreatedBy { get; set; }

        DateTime CreatedOn { get; set; }

        string LastModifiedBy { get; set; }

        DateTime? LastModifiedOn { get; set; }
    }
}
