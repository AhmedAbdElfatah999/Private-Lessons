
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Private_Lessons.Models
{
    public partial class exam_question{
       [Key]
public int id { get; set; }
 public int question_id { get; set; }
 public int exam_id { get; set; }

       [ForeignKey(nameof(question_id))]
       public question question { get; set; }

       [ForeignKey(nameof(exam_id))]
       public exam exam { get; set; }

    }}