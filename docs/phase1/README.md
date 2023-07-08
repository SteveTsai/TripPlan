## 1. Document Contents
### Activities.csv
  - Point Info
  - Reservation
  - Duration
  - Note
  - Google stars, reviews
  - Google location

### Plan-arg.txt
  * A list of Day plan
  * A Day plan includes
    * Destination (City)
    * Day, start time 
    * A list of (event Id or Name, Duration)

### Trip.Txt
  * A list of Day plan
  * A Day plan includes
  * Destination (City)
  * Day, start time
  * A list of (event Id or Name, Duration, Point Info, Google stars, reviews)
  * A list of Transporation time & Google Map Route between 2 events, currently only by car.
      * Transporation duration is calculataed by GoogleMap
      * Get Google Map Route between 2 event locations
      * Calculate each event start time = Previous Event start time + previous event duration + Transportation time
   * A list of event Point Near by other scenary points with Google stars > 4 & Google review counts > 100
   * A list of event Point Near by restarant info with Google stars > 4 & Google review counts > 100
   * A list of event point Near by hotel info with Google stars > 4 & Google review counts > 100
   * Scenary point, restarant & hotel info contains Name, telephone, Google stars, Google review counts

## 2. Activitie File Update Tool
### Crawler
    * Crawl famuous Travel Sites
    * Crawl Google Map for tourist attaction, Stars, Reviews
### AI Request tool
    * ChatGPT
    * Google Search Engine

## 3. Google Map Integration
   1. Write Crawler like End user uses browser access Google Map
   2. Use [Map AIP including Directions API, and Places API](https://developers.google.com/maps?hl=zh-tw) (Need api-key)
   3. [Get reviews from google map api](https://stackoverflow.com/questions/16415827/get-reviews-from-google-map-api)(Need api-key)
   4. https://developers.google.com/maps/documentation/urls/get-started?hl=zh-tw (no api-key)
   5. https://www.google.com/maps/search/?api=1&query=pizza%20restaurant+Taichung+tw  (change city name, and restarent name)
   6.  https://simplemaps.com/data/tw-cities 
   7.  https://www.google.com.tw/maps/dir/Taipei/Taichung/data=!4m2!4m1!3e0 (route from taipei to taichung)
      開車： /data=!4m2!4m1!3e0, 騎腳踏車： /data=!4m2!4m1!3e1 走路: 2, 搭乘大眾運輸： 3 最佳: 5
   8.   https://www.google.com/maps/dir/?api=1&origin=Taipei&destination=TaiChung&travelmode=walking (travelmode=walking bicycling driving transit)
