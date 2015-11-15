﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoDeepDive.Data.DTO {
    public class PartCatalogDTO {
        public PartCatalogDTO() {
            Parts = new List<PartDTO>();
        }
        public List<PartDTO> Parts { get; set; }
        public IEnumerable<PartDTO> getSelectedParts() {
            return Parts.Where(x => x.Selected).ToList();
        }
    }
}