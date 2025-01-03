select * from Applications

select ClassName from LicenseClasses where LicenseClassID = 3

select * from LocalDrivingLicenseApplications

select TestAppointmentID as AppointmentID, AppointmentDate, PaidFees, IsLocked  from TestAppointments where LocalDrivingLicenseApplicationID = 31 and TestTypeID = 2

select * from LocalDrivingLicenseApplications_View

select PassedTestCount from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = 31

select * from TestAppointments

select TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID
,IsLocked from TestAppointments

insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked)
values ()

select * from TestAppointments_View

select * from Tests

select TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID from Tests


select * from TestTypes

select * from ApplicationTypes

select * from Users

Select FirstName +' ' +SecondName +' '+ ThirdName +' '+ LastName as FullName from People where PersonID = 1

select ClassName from LicenseClasses where LicenseClassID = 7


select * from LicenseClasses

select found = 1  from Tests where TestAppointmentID =6

select TestAppointmentID as AppointmentID, AppointmentDate, PaidFees, IsLocked
            from TestAppointments order by TestAppointmentID  DESC

update TestAppointments 
set IsLocked = 0 where TestAppointmentID = 1072 

select * from Tests

update Tests 
set TestResult = 0 where TestAppointmentID = 1072 
delete Tests where TestID = 36 and TestID = 37

select found = 1  from Tests where TestAppointmentID =72
select found = 1  from Tests where TestAppointmentID =88

select ApplicationFees from ApplicationTypes where ApplicationTypeID = 8

select Found=1  from Tests where TestAppointmentID =1072 and TestResult = 1

select * from Licenses

select LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees,
IsActive, IssueReason, CreatedByUserID from Licenses

insert into Licenses 

select * from LicenseClasses

select ClassFees from LicenseClasses

select * from Drivers

select DriverID,CreatedByUserID, CreatedDate  from Drivers where PersonID = 1025


select CreatedByUserID from Drivers


select * from Drivers_View

select  DriverID as 'Driver ID', PersonID as 'Person ID', NationalNo as 'National No', FullName as 'Full Name' ,
CreatedDate as 'Date', NumberOfActiveLicenses as 'Active Licenses'   from Drivers_View 


SELECT Found = 1 from Drivers WHere PersonID = 102

Update  Applications
set ApplicationStatus = 1 where ApplicationID = 2070

select * from Applications

Select * from Licenses WHERE ApplicationID = 2070

Select LicenseID, ApplicationID, ClassName, IssueDate, ExpirationDate, IsActive from Licenses 
inner join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID
WHERE DriverID = 8

select PersonID from Licenses inner join Drivers on Licenses.DriverID = Drivers.DriverID
where LicenseID = 19

select * from InternationalLicenses

select InternationalLicenseID as 'Int.LicenseID', InternationalLicenses.ApplicationID, IssuedUsingLocalLicenseID as 'L.LicenseID', InternationalLicenses.IssueDate,
InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive from InternationalLicenses 
inner join Licenses
on InternationalLicenses.DriverID = Licenses.DriverID
where LicenseID = 19


select Found = 1 from InternationalLicenses where IssuedUsingLocalLicenseID = 17

select InternationalLicenseID from InternationalLicenses inner join Licenses
on InternationalLicenses.DriverID = Licenses.DriverID
where LicenseID = 19

select LocalDrivingLicenseApplicationID from LocalDrivingLicenseApplications inner join Licenses
                on LocalDrivingLicenseApplications.ApplicationID = Licenses.ApplicationID
                where LicenseID = 19


select InternationalLicenseID as 'Int.LicenseID', InternationalLicenses.ApplicationID,DriverID, IssuedUsingLocalLicenseID as 'L.LicenseID', InternationalLicenses.IssueDate,
InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive from InternationalLicenses 

update Licenses 
set ExpirationDate = '2014-12-01'
where LicenseID = 19
 
 update Licenses 
set IsActive = 0
where LicenseID =28

 select * from Licenses

  select * from DetainedLicenses

  select DetainID, LicenseID, DetainDate,FineFees,CreatedByUserID, IsReleased,  ReleaseDate, ReleasedByUserID, ReleaseApplicationID from DetainedLicenses

insert into DetainedLicenses (LicenseID, DetainDate,FineFees,CreatedByUserID, IsReleased,  ReleaseDate, ReleasedByUserID, ReleaseApplicationID )
values (LicenseID, DetainDate,FineFees,CreatedByUserID, IsReleased,  ReleaseDate, ReleasedByUserID, ReleaseApplicationID )

select SCOPE_IDENTITY();
  select *from Drivers_View

select DetainID, DetainedLicenses.LicenseID, DetainDate, IsReleased, FineFees, ReleaseDate,NationalNo, FullName, ReleaseApplicationID from DetainedLicenses
inner  join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
inner join Drivers_View on Drivers_View.DriverID = Licenses.DriverID;

select Found=1 from DetainedLicenses where IsReleased = 0
and LicenseID = 153

Select * from DetainedLicenses WHERE LicenseID = 15

select * from Licenses

update DetainedLicenses 
set IsReleased = 1
where LicenseID = 29