﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Region
    {
		public string Id { get; set; }
		[Display(Name="Bölge Adı")]
		public string Name { get; set; }
        [Display(Name = "Bölge Türü")]
        public RegionType RegionType { get; set; }
		[Display(Name = "Üst Bölge")]
		public string ParentRegionId { get; set; }
        [Display(Name = "Üst Bölge")]
        [ForeignKey("ParentRegionId")]
		public Region ParentRegion { get; set; }

		public virtual ICollection<Region> ChildRegions { get; set; }
		public virtual ICollection<Supplier> Suppliers { get; set; }
	}
}
