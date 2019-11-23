
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Private_Lessons.Models
{
    public partial class subject_teachers{
            [Key]
public int id { get; set; }
     public int subject_id { get; set; }
     public int teacher_id { get; set; }
     
       [ForeignKey(nameof(subject_id))]
       public subject subject { get; set; }

       [ForeignKey(nameof(teacher_id))]
       public teachers teachers { get; set; }

    }}