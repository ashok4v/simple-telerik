// (c) Copyright 2002-2010 Telerik 
// This source is subject to the GNU General Public License, version 2
// See http://www.gnu.org/licenses/gpl-2.0.html. 
// All other rights reserved.

namespace Telerik.Web.Mvc.UI
{
    using System.Web.Mvc;

    public interface IGridDataKey
    {
        string Name
        {
            get;
        }

        string RouteKey
        {
            get;
        }
    }
    
    public interface IGridDataKey<T> : IGridDataKey
            where T : class
    {

        object GetValue(T dataItem);
#if MVC2
        string HiddenFieldHtml(HtmlHelper<T> htmlHelper);
#endif
    }
}
