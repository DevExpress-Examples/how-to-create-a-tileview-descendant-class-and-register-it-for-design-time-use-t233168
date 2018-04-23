﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace MyXtraGrid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
    
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyTileView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyTileViewInfoRegistrator());
        }
    }
}
