//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComboBoxLesson.DbEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderHasProduct
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public string ProductArticleNumber { get; set; }
        public Nullable<int> CountProducts { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Order Order1 { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product Product1 { get; set; }
    }
}