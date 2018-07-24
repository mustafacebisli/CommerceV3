﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Supplier
    {
		public string Id { get; set; }
		[Display(Name = "Tedarikçi Adı")]
		public string Name { get; set; }
        [Display(Name = "Bölge")]
        public string RegionId { get; set; }
		[Display(Name = "Bölge")]
		[ForeignKey("RegionId")]
		public Region Region { get; set; }

		[Display(Name = "Oluşturan Kullanıcı")]
		public string CreatedBy { get; set; }
		[Display(Name = "Oluşturulma Tarihi")]
		public DateTime CreateDate { get; set; }
		[Display(Name = "Güncelleyen Kullanıcı")]
		public string UpdatedBy { get; set; }
		[Display(Name = "Güncelleme Tarihi")]
		public DateTime UpdateDate { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}
