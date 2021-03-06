﻿// (c) Copyright 2002-2010 Telerik 
// This source is subject to the GNU General Public License, version 2
// See http://www.gnu.org/licenses/gpl-2.0.html. 
// All other rights reserved.

namespace Telerik.Web.Mvc.UI
{

    using System.Collections.Generic;

    public interface IGridColumn
    {
        bool IsLast
        {
            get;
        }

        IGridColumnSerializer CreateSerializer();

        string ClientTemplate
        {
            get;
            set;
        }

        bool Encoded
        {
            get;
            set;
        }

        IDictionary<string, object> HeaderHtmlAttributes 
        { 
            get; 
        }
        
        bool Hidden 
        { 
            get; 
            set; 
        }
        
        IDictionary<string, object> HtmlAttributes 
        { 
            get; 
        }

        string Title 
        { 
            get; 
            set; 
        }
        
        bool Visible 
        { 
            get; 
            set; 
        }
        
        string Width 
        { 
            get; 
            set; 
        }

        IGrid Grid
        {
            get;
        }
    }
}
