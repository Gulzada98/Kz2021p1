﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.EfStuff.Model
{
	[Table("Answer", Schema = "Police")]
	public class Answer : BaseModel
    {
		public string Description { get; set; }
		public bool IsRight { get; set; }


		public long QuestionId { get; set; }
		public virtual Question Question { get; set; }
	}
}
