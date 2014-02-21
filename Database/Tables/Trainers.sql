CREATE TABLE [dbo].[Trainers]
(
    [UserId] INT NOT NULL, 
    [TrainingId] INT NOT NULL, 
    CONSTRAINT [FK_Trainers_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_Trainers_Trainings] FOREIGN KEY ([TrainingId]) REFERENCES [Trainings]([TrainingId]), 
    PRIMARY KEY ([UserId], [TrainingId]) 
)
