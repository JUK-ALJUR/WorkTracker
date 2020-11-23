﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DataModels
{
	public class RX_Job
	{
		public Guid? Id { get; set; }
		public int? ContractorID { get; set; }
		
		public string Name { get; set; } //[Max 50]
		public  string Status { get; set; } //[Max 50]
		public int? Floor { get; set; }
		public int? Room { get; set; }
		public string DelayReason { get; set; } //[Max 50]
		public DateTime? DateCreated { get; set; }
		public DateTime? DateCompleted { get; set; }
		public DateTime? DateDelayed { get; set; }
		public int? StatusNum { get; set; }
		public int? RJobID { get; set; }
		public RX_RoomType Rx_RoomType { get; set; }
		public Guid? RoomTypeId { get; set; }
    }
}