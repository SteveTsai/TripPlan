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
