package clockProject;

public class Clock {
	
	private int hours=00, minutes=00;
	private static int count = 0;
	private int idNum;
	
	
	public Clock(int hours, int minutes) {
		setHours(hours);
		setMinutes(minutes);
		count++;
		this.idNum = count;
	}
	
	public Clock() {
		this(0,0);
	}
	
	public Clock(Clock other) {
		this.hours = other.hours;
		this.minutes = other.minutes;
		count++;
		this.idNum = count;
	}
	
	public void setMinutes(int minutes) {
		if(hours >= 0 && hours <=23)
			this.minutes = minutes;
	}
	public void setHours(int hours) {
		if (minutes >= 0 && minutes <= 59)
			this.hours = hours;
	}
	public int getMinutes() {
		return minutes;
	}
	public int getHours() {
		return hours;
	}
	public int getIdNum() {
		return idNum;
	}
	public static int getCount() {
		return count;
	}
	public void add(int minutesToAdd) {
		this.minutes += minutesToAdd;
		if(this.minutes >= 60) {
			while(this.minutes>=60) {
				this.hours++;
				this.minutes-=60;
				if(this.hours>=24)
					this.hours=0;
			}
		}
	}
	public void subtract(int minutesToSubtract) {
		this.minutes-=minutesToSubtract;
		if(this.minutes<0) {
			while(this.minutes<0) {
				hours--;
				this.minutes+=60;
				if(this.hours<0)
					this.hours=12;
			}
		}
	}
	public boolean equals(Clock other) {
		return this.hours == other.hours && this.minutes == other.minutes;
	}
	public boolean isNight() {
		return this.hours < 5 || hours > 20;
	}
	public int minutesToMidNights() {
	    int minutesRemaining = 0;
	    if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59) {
	        if (hours < 24) {
	            minutesRemaining = (24 - hours - 1) * 60 + (60 - minutes);
	        }
	    }
	    return minutesRemaining;
	}
	public boolean isEarlierThan(Clock other) {
	    if (this.hours < other.hours) {
	        return true;
	    } else if (this.hours == other.hours && this.minutes < other.minutes) {
	        return true;
	    }
	    return false;
	}
	public String toString() {
		if(minutes < 10)
			return hours+":"+"0"+minutes;
		return hours+":"+minutes;  
	}
	
}
