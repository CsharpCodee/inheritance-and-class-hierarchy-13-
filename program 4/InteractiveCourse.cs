using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._4
{
    public class InteractiveCourse: Course
    {
        public int NumberOfExercises {  get; set; }
        public string AssessmentSystem {  get; set; }
        public InteractiveCourse(int numberOfExercises, string assessmentSystem, string title, string desription, string author, decimal price) : base(title, desription, author, price) 
        {
            NumberOfExercises = numberOfExercises;
            AssessmentSystem = assessmentSystem;
        }
        public override string StartLearning()
        {
            return $"Начат интерактивный курс: {Title}. количество упражнений: {NumberOfExercises}.";
        }
    }
}
