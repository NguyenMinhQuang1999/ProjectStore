﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
  public  class ItemGroupModel
    {
        public string parent_item_group_id { get; set; }
        public string item_group_id { get; set; }
        public string item_group_name { get; set; }
        public  string url { set; get; }
        public short? seq_num { get; set; }
        public List<ItemGroupModel> children { get; set; }
        public string type { get; set; }
    }
}
