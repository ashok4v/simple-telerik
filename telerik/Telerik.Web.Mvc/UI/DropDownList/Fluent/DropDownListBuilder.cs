﻿namespace Telerik.Web.Mvc.UI.Fluent
{
    using System;
    using System.Web.Mvc;
    using System.Collections.Generic;

    using Extensions;
    using Infrastructure;


    public class DropDownListBuilder : DropDownBuilderBase<DropDownList, DropDownListBuilder>
    {
        public DropDownListBuilder(DropDownList component)
            : base(component)
        {
        }

        /// <summary>
        /// Use it to set selected item index
        /// </summary>
        /// <param name="index">Item index.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Telerik().DropDownList()
        ///             .Name("DropDownList")
        ///             .SelectedIndex(0);
        /// %&gt;
        /// </code>
        /// </example>
        public DropDownListBuilder SelectedIndex(int index)
        {
            Guard.IsNotNegative(index, "index");

            Component.SelectedIndex = index;

            return this;
        }

        /// <summary>
        /// Use it to configure Data binding.
        /// </summary>
        /// <param name="configurator">Action that configures the data binding options.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Telerik().DropDownList()
        ///             .Name("DropDownList")
        ///             .DataBinding(dataBinding => dataBinding
        ///                .Ajax().Select("_AjaxLoading", "DropDownList")
        ///             );
        /// %&gt;
        /// </code>
        /// </example>
        public DropDownListBuilder DataBinding(Action<DropDownListDataBindingConfigurationBuilder> configurator)
        {
            Guard.IsNotNull(configurator, "configurator");

            configurator(new DropDownListDataBindingConfigurationBuilder(Component.DataBinding));

            return this;
        }
    }
}
