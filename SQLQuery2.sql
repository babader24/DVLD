select * from Applications

select ClassName from LicenseClasses where LicenseClassID = 3

select * from LocalDrivingLicenseApplications

select TestAppointmentID as AppointmentID, AppointmentDate, PaidFees, IsLocked  from TestAppointments where LocalDrivingLicenseApplicationID = 31 and TestTypeID = 2

select * from LocalDrivingLicenseApplications_View

select PassedTestCount from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = 31

select * from TestAppointments

select * from TestAppointments_View

select * from Tests

select * from TestTypes

select * from ApplicationTypes

select * from Users

Select FirstName +' ' +SecondName +' '+ ThirdName +' '+ LastName as FullName from People where PersonID = 1

select ClassName from LicenseClasses where LicenseClassID = 7