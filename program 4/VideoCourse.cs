using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._4
{
    public class VideoCourse : Course
    {
        public int NumberOfVideo {  get; set; }
        public int TotalDuration { get; set; }
        public VideoCourse(int numberOfVideo, int totalDuration, string title, string desription, string author, decimal price):base(title, desription, author, price) 
        {
            NumberOfVideo = numberOfVideo;
            TotalDuration = totalDuration;
        }
        public string GetVideoCourseInfo()
        {
            return $"{GetInfo()}\n Количество видео: {NumberOfVideo}, общая длительность: {TotalDuration}.";
        }
        public override string StartLearning()
        {
            return $"Начат видуеокурс: {Title}. Общая длительность: {TotalDuration} минут.";
        }
    }
}
