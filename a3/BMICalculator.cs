namespace a3;

enum UnitType
{
    Metric,
    Imperial
}

enum Gender {
  Female,
  Male
}

enum ActivityLevel
{
    Sedentary,
    LightlyActive,
    ModeratelyActive,
    VeryActive,
    ExtraActive
}

class BMICalculator
{
  private double height;
  private double weight;
  private UnitType unit;
  // name nullable string
  private string name = "NoName";
  private Gender gender;
  private ActivityLevel activityLevel;
  private int age;

  public double CalculateBMI()
  {
    // height from cm to m
    double heightInMeters = height / 100;
    // showmessage height and weight
    // MessageBox.Show("Height: " + height + " Weight: " + weight);
    return weight / (heightInMeters * heightInMeters);
  }

  public double CalculateBMR() {
    // Men: BMR = 88.362 + (13.397 x weight in kg) + (4.799 x height in cm) – (5.677 x age in years)
    // Women: BMR = 447.593 + (9.247 x weight in kg) + (3.098 x height in cm) – (4.330 x age in years)
    if (this.gender == Gender.Female) {
      return 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);
    } else {
      return 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);
    }
  }
  public Dictionary<string, string> NormalWeight()
  {
    // calculate what is the normal weight for the height
    double bmi = CalculateBMI();
    double upper = 0;
    double lower = 0;
    if (unit == UnitType.Metric)
    {
      upper = Math.Round(25 * (height * height) / 10000, 2);
      lower = Math.Round(18.5 * (height * height) / 10000, 2);
    }
    else
    {
      // to lb
      upper = Math.Round(25 * (height * height) / 10000 * 2.20462, 2);
      lower = Math.Round(18.5 * (height * height) / 10000 * 2.20462, 2);
    }
    return new Dictionary<string, string> { { "min", lower.ToString() }, { "max", upper.ToString() } };
  }

  public string BmiWeightCategory() {
    double bmi = CalculateBMI();
    if (bmi < 18.5) {
      return "Underweight";
    } else if (bmi < 25) {
      return "Normal weight";
    } else if (bmi < 30) {
      return "Overweight";
    } else {
      return "Obesity";
    }
  }

  // getters and setters
  public double getHeight()
  {
    return height;
  }
  public void setHeight(double cm)
  {
    this.height = cm;
  }
  public void setHeight(int feet, int inches)
  {
    // convert feet and inches to cm
    double feetcm = feet * 30.48;
    double inchescm = inches * 2.54;
    this.height = feetcm + inchescm;
  }
  public double getWeight()
  {
    return weight;
  }
  public void setWeight(double w)
  {
    if (unit == UnitType.Imperial)
    {
      this.weight = w / 2.205;
    }
    else
    {
      this.weight = w;
    }
  }
  public UnitType getUnit()
  {
    return unit;
  }
  public void setUnit(UnitType unit)
  {
    this.unit = unit;
  }
  public string getName()
  {
    return name;
  }
  public void setName(string name)
  {
    this.name = name;
  }
  public Gender getGender()
  {
    return this.gender;
  }
  public void setGender(Gender g)
  {
    this.gender = g;
  }
  public ActivityLevel getActivityLevel()
  {
    return this.activityLevel;
  }
  public void setActivityLevel(ActivityLevel al)
  {
    this.activityLevel = al;
  }
  public int getAge()
  {
    return this.age;
  }
  public void setAge(int age)
  {
    this.age = age;
  }

}
