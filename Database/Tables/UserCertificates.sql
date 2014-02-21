CREATE TABLE [dbo].[UserCertificates]
(
	[UserId] INT NOT NULL , 
    [CertificateId] INT NOT NULL, 
    PRIMARY KEY ([UserId], [CertificateId]), 
    CONSTRAINT [FK_UserCertificates_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_UserCertificates_Certificates] FOREIGN KEY ([CertificateId]) REFERENCES [Certificates]([CertificateId])
)
