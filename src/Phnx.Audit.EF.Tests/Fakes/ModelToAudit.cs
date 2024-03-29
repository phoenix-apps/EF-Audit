﻿using System;
using System.Collections.Generic;

namespace Phnx.Audit.EF.Tests.Fakes
{
    public class ModelToAudit
    {
        public ModelToAudit()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string OneToOneChildModelId { get; set; }

        public OneToOneChildModel OneToOneChildModel { get; set; }

        public IEnumerable<OneToManyChildModel> OneToManyChildModels { get; set; }

        public IEnumerable<ManyToManyChildModel> ManyToManyChildModels { get; set; }

        public List<AuditEntryModel> Audits { get; set; }
    }
}
