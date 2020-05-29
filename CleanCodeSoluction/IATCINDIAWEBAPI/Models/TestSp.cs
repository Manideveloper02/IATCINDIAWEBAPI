using IATCINDIAWEBAPI.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IATCINDIAWEBAPI.Models
{
    [Table("test")]
    public class TestSp :  IEntity
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
}
