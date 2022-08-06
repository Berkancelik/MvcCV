#nullable disable

using System.ComponentModel.DataAnnotations;

namespace MvcCV.EntiyLayer.Concrete
{
    public partial class Education
    {
        public int Id { get; set; }
        //[Required(ErrorMessage ="Bu alanı boş geçemezsiniz")]
        public string Title { get; set; }
        public string SubTitle1 { get; set; }
        public string SubTitle2 { get; set; }
        public string GradeAverage { get; set; }
    }
}
