//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToursApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelComment
    {
        public int id { get; set; }
        public int Hotelid { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> CreationData { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
