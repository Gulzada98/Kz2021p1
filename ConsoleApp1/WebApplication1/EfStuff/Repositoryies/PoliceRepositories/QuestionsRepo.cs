﻿using WebApplication1.EfStuff.Model;
using WebApplication1.EfStuff.Repositoryies.PoliceRepositories.Interfaces;

namespace WebApplication1.EfStuff.Repositoryies
{
	public class QuestionsRepo : BaseRepository<Question>, IQuestionsRepo
	{
		public QuestionsRepo(KzDbContext kzDbContext) : base(kzDbContext) 
		{

		}
    }
}
