
namespace A1 {
  /**
    * @class Clock
    * @brief A class that checks the time difference between your timezone and another timezone
    */
  class Clock {

    private DateTime now;
    private DateTime destination;
    private TimeZoneInfo local;
    private TimeZoneInfo tz;
    private double offset;

    public Clock(string city) {
      this.now = DateTime.Now;
      // get the timezone of the city
      this.local = TimeZoneInfo.Local;
      this.tz = TimeZoneInfo.FindSystemTimeZoneById(city);
      // get the offset between the two timezones
      this.offset = (this.tz.BaseUtcOffset - this.local.BaseUtcOffset).TotalHours;
      // current time in the city
      this.destination = this.now.AddHours(this.offset);
    }

    public void DisplayTime() {
      Console.WriteLine();
      // your current time
      Console.WriteLine("Your current time is: " + this.now.ToString("h:mm tt"));
      // the time in the city
      Console.WriteLine("The time in " + this.tz.DisplayName + " is " + this.destination.ToString("h:mm tt"));
      Console.WriteLine();
      // the difference between the two times
      Console.WriteLine("The difference between the two times is " + this.offset + " hours");
    }

  }
}
