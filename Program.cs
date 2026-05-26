// string region = null;
// Console.WriteLine(region.ToUpper());

// string? region = null;
// string? upperRegion = region?.ToUpper();
// Console.WriteLine(upperRegion);
// string displayRegion = region ?? "Region not specified";
// Console.WriteLine("Region (cpalesced):{displayRegion}");
// region ??= "Addis Abeba";
// Console.WriteLine("Reion(assigned):{region}");
// string studentName = "Abebe";
// string studentId = "STU-001";
// int enrollmentCount = 3;
// decimal grantAmount = 1999.99m;
// DateTime enrolledAt = DateTime.UtcNow;
// string? campusRegion = null;

// Console.WriteLine($"Student: {studentName} {studentId}");
// Console.WriteLine($"Enrollment Count: {enrollmentCount}");
// Console.WriteLine($"Grant Amount: {grantAmount:C}");
// Console.WriteLine($"Enrolled At: {enrolledAt: yyyy-MM-dd HH:mm:ss} UTC");
// Console.WriteLine($"Campus Region: {campusRegion ?? "Not specified"}");

// double grantPerStudent = 1999.99;
// double totalAllocation = grantPerStudent * 100_000;
// Console.WriteLine($"Total allocated (double): {totalAllocation:R}");


decimal grantPerStudent = 1999.99m;
decimal totalAllocation = grantPerStudent * 100_000;
Console.WriteLine($"Total allocated (double): {totalAllocation}");