﻿using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196124.aspx </remarks>
	[SupportByVersionAttribute("Excel", 14,15,16)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlDataBarFillType
	{
		 /// <summary>
		 /// SupportByVersion Excel 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 14,15,16)]
		 xlDataBarFillSolid = 0,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 14,15,16)]
		 xlDataBarFillGradient = 1
	}
}