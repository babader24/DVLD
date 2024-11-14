use DVLD
select * from LicenseClasses

select * from Licenses

select * from LocalDrivingLicenseApplications

select LocalDrivingLicenseApplicationID,ApplicationID,LicenseClassID from LocalDrivingLicenseApplications

update LocalDrivingLicenseApplications
set  ApplicationID = , LicenseClassID = 
where LocalDrivingLicenseApplicationID = 

update Applications
set  ApplicationStatus = 2
Where Applications.ApplicationID =  (select Applications.ApplicationID from Applications inner join LocalDrivingLicenseApplications on 
	Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
	where LocalDrivingLicenseApplicationID = 2034)




select * from LocalDrivingLicenseApplications_View

select * from Applications

select ApplicationID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,CreatedByUserID from Applications

Update Applications 
       set ApplicantPersonID = 2026, ApplicationDate = Convert(datetime,'2024-11-14 00:00:00.000',120), ApplicationTypeID = 1,
	   ApplicationStatus = 1,LastStatusDate = Convert(datetime,'2024-11-14 00:00:00.000',120),
	   PaidFees = (select ApplicationFees from ApplicationTypes where ApplicationTypeID =1),
       CreatedByUserID = 15
	   where ApplicationID = 1071

begin transaction
delete LocalDrivingLicenseApplications
Where LocalDrivingLicenseApplicationID = 2034;

delete Applications 
where ApplicationID = 1071(select ApplicationID from LocalDrivingLicenseApplications  where LocalDrivingLicenseApplicationID = 2034)

commit;






select * from ApplicationTypes

select * from Tests
select * from TestAppointments

select LocalDrivingLicenseApplications.ApplicationID,LicenseClassID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,
	   LastStatusDate,CreatedByUserID from LocalDrivingLicenseApplications inner join Applications 
	   on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID 
	   WHere LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 1034

Select * from ApplicationTypes