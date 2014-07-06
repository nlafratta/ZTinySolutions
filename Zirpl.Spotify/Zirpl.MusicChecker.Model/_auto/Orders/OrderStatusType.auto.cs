﻿using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class OrderStatusType : DictionaryEntityBase<byte, OrderStatusTypeEnum>
    {
		public override string Name { get; set; }
		public virtual string CustomerFacingName { get; set; }
    }
}

