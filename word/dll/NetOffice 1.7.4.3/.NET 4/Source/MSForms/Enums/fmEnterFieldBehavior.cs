﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSFormsApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSForms 2
	 /// </summary>
	[SupportByVersion("MSForms", 2)]
	[EntityType(EntityType.IsEnum)]
	public enum fmEnterFieldBehavior
	{
		 /// <summary>
		 /// SupportByVersion MSForms 2
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSForms", 2)]
		 fmEnterFieldBehaviorSelectAll = 0,

		 /// <summary>
		 /// SupportByVersion MSForms 2
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSForms", 2)]
		 fmEnterFieldBehaviorRecallSelection = 1
	}
}