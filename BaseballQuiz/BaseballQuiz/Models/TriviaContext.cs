using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaseballQuiz.Models
{
   public class TriviaContext : DbContext
    {
        public TriviaContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<TriviaQuestion> TriviaQuestions { get; set; }
        public DbSet<TriviaOption> TriviaOptions { get; set; }
        public DbSet<TriviaAnswer> TriviaAnswers { get; set; }
    }

   public class TriviaDatabaseInitializer : CreateDatabaseIfNotExists<TriviaContext>
   {
       protected override void Seed(TriviaContext context)
       {
           base.Seed(context);

           var questions = new List<TriviaQuestion>();

           questions.Add(new TriviaQuestion
           {
               Title = "Who won Game 2 of the 2013 NLCS?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Los Angleles", IsCorrect= false },
                    new TriviaOption { Title= "Pittsburg", IsCorrect= false },
                    new TriviaOption { Title= "St. Louis", IsCorrect= true },
                    new TriviaOption { Title= "Atlanta", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What AL pitcher had the most wins at the end of the 2013 season?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "C.J. Wilson", IsCorrect= false },
                    new TriviaOption { Title= "Matt Moore", IsCorrect= false },
                    new TriviaOption { Title= "Bartolo Colon", IsCorrect= false },
                    new TriviaOption { Title= "Max Scherzer", IsCorrect= true }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What player had the highest overall OBP in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Andrew McCutchen", IsCorrect= false },
                    new TriviaOption { Title= "Joey Votto", IsCorrect= false },
                    new TriviaOption { Title= "Miguel Cabrera", IsCorrect= true },
                    new TriviaOption { Title= "Mike Trout", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What AL player totaled 53 homeruns in the 2013 season?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Miguel Cabrera", IsCorrect= false },
                    new TriviaOption { Title= "Adam Dunn", IsCorrect= false },
                    new TriviaOption { Title= "Chris Davis", IsCorrect= true },
                    new TriviaOption { Title= "Edwin Encarnacion", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How many shutouts did Clayton Kershaw pitch in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "2", IsCorrect= true },
                    new TriviaOption { Title= "1", IsCorrect= false },
                    new TriviaOption { Title= "4", IsCorrect= false },
                    new TriviaOption { Title= "3", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How many complete games did David Price pitch in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "1", IsCorrect= false },
                    new TriviaOption { Title= "3", IsCorrect= false },
                    new TriviaOption { Title= "4", IsCorrect= true },
                    new TriviaOption { Title= "2", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What NL player had the highest batting average in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Chris Johnson", IsCorrect= false },
                    new TriviaOption { Title= "Freddie Freeman", IsCorrect= false },
                    new TriviaOption { Title= "Michael Cuddyer", IsCorrect= true },
                    new TriviaOption { Title= "Yadier Molina", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What AL pitcher had the lowest ERA in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Hisashi Iwakuma", IsCorrect= false },
                    new TriviaOption { Title= "Anibal Sanchez", IsCorrect= true },
                    new TriviaOption { Title= "Bartolo Colon", IsCorrect= false },
                    new TriviaOption { Title= "Yu Darvish", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What team had the highest RBI percentage in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Boston Red Sox", IsCorrect= true },
                    new TriviaOption { Title= "Detroit Tigers", IsCorrect= false },
                    new TriviaOption { Title= "Oakland Athletics", IsCorrect= false },
                    new TriviaOption { Title= "St. Louis Cardinals", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How many doubles did Manny Machado have in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "51", IsCorrect= true },
                    new TriviaOption { Title= "49", IsCorrect= false },
                    new TriviaOption { Title= "47", IsCorrect= false },
                    new TriviaOption { Title= "53", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How many hits did Andrew McCutchen have in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "185", IsCorrect= true },
                    new TriviaOption { Title= "190", IsCorrect= false },
                    new TriviaOption { Title= "180", IsCorrect= false },
                    new TriviaOption { Title= "195", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What NL player had the most stolen bases in 2013??",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Jean Segura", IsCorrect= false },
                    new TriviaOption { Title= "Carlos Gomez", IsCorrect= false },
                    new TriviaOption { Title= "Starling Marte", IsCorrect= false },
                    new TriviaOption { Title= "Eric Young Jr.", IsCorrect= true }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "Who had the highest percentage of innings pitched in the NL in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Cliff Lee", IsCorrect= false },
                    new TriviaOption { Title= "Clayton Kershaw", IsCorrect= false },
                    new TriviaOption { Title= "Adam Wainwright", IsCorrect= true },
                    new TriviaOption { Title= "Cole Hamels", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What AL player had the most runs scored in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Austin Jackson", IsCorrect= false },
                    new TriviaOption { Title= "Miguel Cabrera", IsCorrect= false },
                    new TriviaOption { Title= "Mike Trout", IsCorrect= true },
                    new TriviaOption { Title= "Chris Davis", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What AL player had an ERA of 3.07 in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Chris Sale", IsCorrect= true },
                    new TriviaOption { Title= "Felix Hernandez", IsCorrect= false },
                    new TriviaOption { Title= "Max Scherzer", IsCorrect= false },
                    new TriviaOption { Title= "Bartolo Colon", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "What NL player had the most homeruns in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Paul Goldschmidt", IsCorrect= false },
                    new TriviaOption { Title= "Jay Bruce", IsCorrect= false },
                    new TriviaOption { Title= "Domonic Brown", IsCorrect= false },
                    new TriviaOption { Title= "Pedro Alvarez", IsCorrect= true }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How many saves did Craig Kimbrel have in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "45", IsCorrect= false },
                    new TriviaOption { Title= "50", IsCorrect= true },
                    new TriviaOption { Title= "55", IsCorrect= false },
                    new TriviaOption { Title= "51", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How many wins did Zack Greinke have in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "15", IsCorrect= true},
                    new TriviaOption { Title= "11", IsCorrect= false },
                    new TriviaOption { Title= "13", IsCorrect= false },
                    new TriviaOption { Title= "9", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How many triples did Brett Gardner have in 2013?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "11", IsCorrect= false },
                    new TriviaOption { Title= "8", IsCorrect= false },
                    new TriviaOption { Title= "9", IsCorrect= false },
                    new TriviaOption { Title= "10", IsCorrect= true }
                }).ToList()
           });

           questions.ForEach(a => context.TriviaQuestions.Add(a));

           context.SaveChanges();
       }
   }
}