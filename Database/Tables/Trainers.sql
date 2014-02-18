CREATE TABLE [dbo].[Trainers]
(
	[TrainerId] INT NOT NULL PRIMARY KEY IDENTITY(0, 1), 
    [UserId] INT NOT NULL, 
    [TrainingId] INT NOT NULL, 
    CONSTRAINT [FK_Trainers_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_Trainers_Trainings] FOREIGN KEY ([TrainingId]) REFERENCES [Trainings]([TrainingId]) 
)
