﻿using System;
using Microsoft.EntityFrameworkCore;
using Phnx.Audit.EF.Fluent;
using Phnx.Audit.EF.Models;

namespace Phnx.Audit.EF
{
    public interface IAuditService<TContext> where TContext : DbContext
    {
        FluentAudit<TContext, TAuditEntry, TEntity> GenerateEntry<TAuditEntry, TEntity>(TEntity entity)
            where TAuditEntry : AuditEntryDataModel<TEntity>, new()
            where TEntity : class;

        FluentAudit<TContext, TAuditEntry, TEntity> GenerateEntry<TAuditEntry, TEntity>(TEntity entity, DateTime auditedOn)
            where TAuditEntry : AuditEntryDataModel<TEntity>, new()
            where TEntity : class;
    }
}