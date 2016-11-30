# EZ_SysInfo
Prints out all the sysinfo in an easy to read way. Also shows how to smartly use reflections . . . although the time it took me to figure this out was probably equal to just typing out all the property printing . . . but this is WAY cooler.

Code:
	

	private SystemInfo sys;
	void Start () {
        sys = new SystemInfo();
        var info = typeof(SystemInfo).GetProperties();
        txt.text += "\nOn: " + Application.platform;
        for(int x = 0; x < info.Length; x++) {
            if (info[x].CanRead) { 
                txt.text += "\n" + info[x].Name + ": " + info[x].GetValue(sys, null);
            }
        }
