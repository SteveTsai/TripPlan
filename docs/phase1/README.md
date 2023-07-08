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
   2. Use [Map AIP including Directions API, and Places API](https://developers.google.com/maps?hl=zh-tw)
   3. [Get reviews from google map api](https://stackoverflow.com/questions/16415827/get-reviews-from-google-map-api)
