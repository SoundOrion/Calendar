//namespace BlazorAppCalendar.Data
//{
//    public class EventService
//    {
//        public List<Event> GetEventAsync()
//        {
//            List<Event> EventList = new List<Event>
//            {
//                new Event { Id = 1, Name =  "ミーティング", StartDate = new DateTime(2023, 1, 1), EndDate = new DateTime(2023, 1, 3), Color = "blue"},
//                new Event { Id = 2, Name =  "会議", StartDate = new DateTime(2023, 1, 11), EndDate = new DateTime(2023, 1, 14), Color = "limegreen"},
//                new Event { Id = 3, Name =  "有給", StartDate = new DateTime(2023, 1, 9), EndDate = new DateTime(2023, 1, 13), Color = "deepskyblue"},
//                new Event { Id = 4, Name =  "海外旅行", StartDate = new DateTime(2023, 1, 19), EndDate = new DateTime(2023, 1, 25), Color = "dimgray"},
//                new Event { Id = 5, Name =  "誕生日", StartDate = new DateTime(2023, 1, 31), EndDate = new DateTime(2023, 1, 31), Color = "orange"},
//            };

//            return EventList;
//        }
//    }
//}


////events:
////[
////  { id: 1, name: "ミーティング", start: "2021-01-01", end: "2021-01-01", color: "blue"},
////  { id: 2, name: "イベント", start: "2021-01-02", end: "2021-01-03", color: "limegreen"},
////  { id: 3, name: "会議", start: "2021-01-06", end: "2021-01-06", color: "deepskyblue"},
////  { id: 4, name: "有給", start: "2021-01-08", end: "2021-01-08", color: "dimgray"},
////  { id: 5, name: "海外旅行", start: "2021-01-08", end: "2021-01-11", color: "navy"},
////  { id: 6, name: "誕生日", start: "2021-01-16", end: "2021-01-16", color: "orange"},
////  { id: 7, name: "イベント", start: "2021-01-12", end: "2021-01-15", color: "limegreen"},
////  { id: 8, name: "出張", start: "2021-01-12", end: "2021-01-13", color: "teal"},
////  { id: 9, name: "客先訪問", start: "2021-01-14", end: "2021-01-14", color: "red"},
////  { id: 10, name: "パーティ", start: "2021-01-15", end: "2021-01-15", color: "royalblue"},
////  { id: 12, name: "ミーティング", start: "2021-01-18", end: "2021-01-19", color: "blue"},
////  { id: 13, name: "イベント", start: "2021-01-21", end: "2021-01-21", color: "limegreen"},
////  { id: 14, name: "有給", start: "2021-01-20", end: "2021-01-20", color: "dimgray"},
////  { id: 15, name: "イベント", start: "2021-01-25", end: "2021-01-28", color: "limegreen"},
////  { id: 16, name: "会議", start: "2021-01-21", end: "2021-01-21", color: "deepskyblue"},
////  { id: 17, name: "旅行", start: "2021-01-23", end: "2021-01-24", color: "navy"},
////  { id: 18, name: "ミーティング", start: "2021-01-28", end: "2021-01-28", color: "blue"},
////  { id: 19, name: "会議", start: "2021-01-12", end: "2021-01-12", color: "deepskyblue"},
////  { id: 20, name: "誕生日", start: "2021-01-30", end: "2021-01-30", color: "orange"},
////]