IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [Name_FirstName] nvarchar(max) NULL,
    [Name_LastName] nvarchar(max) NULL,
    [Name_NickName] nvarchar(max) NULL,
    [Emails_Address] nvarchar(max) NULL,
    [Emails_SecundaryAddress] nvarchar(max) NULL,
    [Document_CPF] nvarchar(450) NULL,
    [Document_RG] nvarchar(450) NULL,
    [Document_NumberSUS] nvarchar(450) NULL,
    [UserType] int NOT NULL,
    [Foto] varbinary(max) NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [HealthCenters] (
    [HealthCenterId] int NOT NULL IDENTITY,
    [Title] VARCHAR(120) NULL,
    [Description] VARCHAR(512) NULL,
    [Observation] VARCHAR(512) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_HealthCenters] PRIMARY KEY ([HealthCenterId])
);
GO

CREATE TABLE [Jobs] (
    [Id] nvarchar(450) NOT NULL,
    [Description] nvarchar(50) NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_Jobs] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [MedicalSpecialties] (
    [MedicalSpecialityId] int NOT NULL IDENTITY,
    [Title] VARCHAR(512) NULL,
    [Active] BIT NOT NULL,
    [Description] VARCHAR(512) NULL,
    [Observation] VARCHAR(512) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_MedicalSpecialties] PRIMARY KEY ([MedicalSpecialityId])
);
GO

CREATE TABLE [AddressUsers] (
    [AddressUserId] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    [Street] VARCHAR(512) NULL,
    [Number] VARCHAR(20) NULL,
    [Complement] VARCHAR(512) NULL,
    [District] VARCHAR(512) NULL,
    [City] VARCHAR(512) NULL,
    [State] CHAR(2) NULL,
    [Country] VARCHAR(512) NULL,
    [ZipCode] VARCHAR(100) NULL,
    [Description] VARCHAR(512) NULL,
    [Type] int NOT NULL,
    CONSTRAINT [PK_AddressUsers] PRIMARY KEY ([AddressUserId]),
    CONSTRAINT [FK_AddressUsers_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id])
);
GO

CREATE TABLE [Administrators] (
    [AdministratorId] int NOT NULL IDENTITY,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Administrators] PRIMARY KEY ([AdministratorId]),
    CONSTRAINT [FK_Administrators_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Attendants] (
    [AttendantId] int NOT NULL IDENTITY,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Attendants] PRIMARY KEY ([AttendantId]),
    CONSTRAINT [FK_Attendants_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Doctors] (
    [DoctorId] int NOT NULL IDENTITY,
    [Code] VARCHAR(50) NULL,
    [Crm] VARCHAR(200) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Doctors] PRIMARY KEY ([DoctorId]),
    CONSTRAINT [FK_Doctors_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Managers] (
    [ManagerId] int NOT NULL IDENTITY,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Managers] PRIMARY KEY ([ManagerId]),
    CONSTRAINT [FK_Managers_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Nurses] (
    [NurseId] int NOT NULL IDENTITY,
    [Code] VARCHAR(50) NULL,
    [Crm] VARCHAR(150) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Nurses] PRIMARY KEY ([NurseId]),
    CONSTRAINT [FK_Nurses_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Patients] (
    [PatientId] int NOT NULL IDENTITY,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Patients] PRIMARY KEY ([PatientId]),
    CONSTRAINT [FK_Patients_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [PhoneUser] (
    [PhoneUserId] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    [Number] VARCHAR(100) NULL,
    [Type] int NOT NULL,
    [Observation] VARCHAR(300) NULL,
    CONSTRAINT [PK_PhoneUser] PRIMARY KEY ([PhoneUserId]),
    CONSTRAINT [FK_PhoneUser_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id])
);
GO

CREATE TABLE [AddressHealthCenters] (
    [AddressHealthCenterId] int NOT NULL IDENTITY,
    [HealthCenterId] int NOT NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    [Street] VARCHAR(512) NULL,
    [Number] VARCHAR(20) NULL,
    [Complement] VARCHAR(512) NULL,
    [District] VARCHAR(512) NULL,
    [City] VARCHAR(512) NULL,
    [State] CHAR(2) NULL,
    [Country] VARCHAR(512) NULL,
    [ZipCode] VARCHAR(100) NULL,
    [Description] VARCHAR(512) NULL,
    [Type] int NOT NULL,
    CONSTRAINT [PK_AddressHealthCenters] PRIMARY KEY ([AddressHealthCenterId]),
    CONSTRAINT [FK_AddressHealthCenters_HealthCenters_HealthCenterId] FOREIGN KEY ([HealthCenterId]) REFERENCES [HealthCenters] ([HealthCenterId])
);
GO

CREATE TABLE [PhoneHealthCenter] (
    [PhoneHealthCenterId] int NOT NULL IDENTITY,
    [HealthCenterId] int NOT NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    [Number] VARCHAR(100) NULL,
    [Type] int NOT NULL,
    [Observation] VARCHAR(300) NULL,
    CONSTRAINT [PK_PhoneHealthCenter] PRIMARY KEY ([PhoneHealthCenterId]),
    CONSTRAINT [FK_PhoneHealthCenter_HealthCenters_HealthCenterId] FOREIGN KEY ([HealthCenterId]) REFERENCES [HealthCenters] ([HealthCenterId])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_Jobs_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Jobs] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_Jobs_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Jobs] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [HealthCenterMedicalSpeciality] (
    [HealthCenterMedicalSpecialityId] int NOT NULL IDENTITY,
    [HealthCenterId] uniqueidentifier NOT NULL,
    [HealthCenterId1] int NULL,
    [MedicalSpecialityId] uniqueidentifier NOT NULL,
    [MedicalSpecialityId1] int NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_HealthCenterMedicalSpeciality] PRIMARY KEY ([HealthCenterMedicalSpecialityId]),
    CONSTRAINT [FK_HealthCenterMedicalSpeciality_HealthCenters_HealthCenterId1] FOREIGN KEY ([HealthCenterId1]) REFERENCES [HealthCenters] ([HealthCenterId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_HealthCenterMedicalSpeciality_MedicalSpecialties_MedicalSpecialityId1] FOREIGN KEY ([MedicalSpecialityId1]) REFERENCES [MedicalSpecialties] ([MedicalSpecialityId]) ON DELETE NO ACTION
);
GO

CREATE TABLE [DoctorHealthCenter] (
    [DoctorHealthCenterId] int NOT NULL IDENTITY,
    [DoctorId] uniqueidentifier NOT NULL,
    [DoctorId1] int NULL,
    [HealthCenterId] uniqueidentifier NOT NULL,
    [HealthCenterId1] int NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_DoctorHealthCenter] PRIMARY KEY ([DoctorHealthCenterId]),
    CONSTRAINT [FK_DoctorHealthCenter_Doctors_DoctorId1] FOREIGN KEY ([DoctorId1]) REFERENCES [Doctors] ([DoctorId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_DoctorHealthCenter_HealthCenters_HealthCenterId1] FOREIGN KEY ([HealthCenterId1]) REFERENCES [HealthCenters] ([HealthCenterId]) ON DELETE NO ACTION
);
GO

CREATE TABLE [DoctorMedicalSpeciality] (
    [DoctorMedicalSpecialityId] int NOT NULL IDENTITY,
    [DoctorId] uniqueidentifier NOT NULL,
    [DoctorId1] int NULL,
    [MedicalSpecialityId] uniqueidentifier NOT NULL,
    [MedicalSpecialityId1] int NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_DoctorMedicalSpeciality] PRIMARY KEY ([DoctorMedicalSpecialityId]),
    CONSTRAINT [FK_DoctorMedicalSpeciality_Doctors_DoctorId1] FOREIGN KEY ([DoctorId1]) REFERENCES [Doctors] ([DoctorId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_DoctorMedicalSpeciality_MedicalSpecialties_MedicalSpecialityId1] FOREIGN KEY ([MedicalSpecialityId1]) REFERENCES [MedicalSpecialties] ([MedicalSpecialityId]) ON DELETE NO ACTION
);
GO

CREATE TABLE [HealthCenterNurses] (
    [HealthCenterNurseId] int NOT NULL IDENTITY,
    [HealthCenterId] uniqueidentifier NOT NULL,
    [HealthCenterId1] int NULL,
    [NurseId] uniqueidentifier NOT NULL,
    [NurseId1] int NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_HealthCenterNurses] PRIMARY KEY ([HealthCenterNurseId]),
    CONSTRAINT [FK_HealthCenterNurses_HealthCenters_HealthCenterId1] FOREIGN KEY ([HealthCenterId1]) REFERENCES [HealthCenters] ([HealthCenterId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_HealthCenterNurses_Nurses_NurseId1] FOREIGN KEY ([NurseId1]) REFERENCES [Nurses] ([NurseId]) ON DELETE NO ACTION
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Description', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Jobs]'))
    SET IDENTITY_INSERT [Jobs] ON;
INSERT INTO [Jobs] ([Id], [ConcurrencyStamp], [Description], [Name], [NormalizedName])
VALUES (N'1d4f0035-8448-4018-9a30-4d7b1b7b7aa9', N'4eeafa8a-b946-4660-ac0d-ddfc9a4e8a12', N'Administrador do sistema', N'Administrator', N'ADMINISTRATOR'),
(N'68377797-8fa8-49d9-a824-29441db5de3d', N'36a68435-442e-4c66-bedc-f1f78d52725f', N'Gestor(a)', N'Manager', N'MANAGER'),
(N'6b2ee624-e125-4ab8-b866-a51d98aa40c3', N'70daacf2-2c5e-4806-bdeb-7270b7e82ca8', N'Médico(a)', N'Doctor', N'DOCTOR'),
(N'a7eb93ff-d311-4359-b73e-1924de699865', N'ca7d4c52-61fa-4ac1-9500-0dedf505dc26', N'Enfermeiro(a)', N'Nurse', N'NURSE'),
(N'b90efb92-b9a4-4c47-a6cf-e72fa01a0784', N'd6f630ba-d2a3-479d-a343-aac9d15f1fc6', N'Atendente', N'Attendant', N'ATTENDANT'),
(N'3ffe6a94-bda3-4821-aeed-60ddaa2962e7', N'c32ac403-7b06-446e-9919-34e77d8c20a3', N'Paciente', N'Patient', N'PATIENT');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Description', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Jobs]'))
    SET IDENTITY_INSERT [Jobs] OFF;
GO

CREATE INDEX [IX_AddressHealthCenters_HealthCenterId] ON [AddressHealthCenters] ([HealthCenterId]);
GO

CREATE INDEX [IX_AddressUsers_UserId] ON [AddressUsers] ([UserId]);
GO

CREATE INDEX [IX_Administrators_UserId] ON [Administrators] ([UserId]);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [IX_AspNetUsers_Document_CPF] ON [AspNetUsers] ([Document_CPF]) WHERE [Document_CPF] IS NOT NULL;
GO

CREATE UNIQUE INDEX [IX_AspNetUsers_Document_NumberSUS] ON [AspNetUsers] ([Document_NumberSUS]) WHERE [Document_NumberSUS] IS NOT NULL;
GO

CREATE UNIQUE INDEX [IX_AspNetUsers_Document_RG] ON [AspNetUsers] ([Document_RG]) WHERE [Document_RG] IS NOT NULL;
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

CREATE INDEX [IX_Attendants_UserId] ON [Attendants] ([UserId]);
GO

CREATE INDEX [IX_DoctorHealthCenter_DoctorId1] ON [DoctorHealthCenter] ([DoctorId1]);
GO

CREATE INDEX [IX_DoctorHealthCenter_HealthCenterId1] ON [DoctorHealthCenter] ([HealthCenterId1]);
GO

CREATE INDEX [IX_DoctorMedicalSpeciality_DoctorId1] ON [DoctorMedicalSpeciality] ([DoctorId1]);
GO

CREATE INDEX [IX_DoctorMedicalSpeciality_MedicalSpecialityId1] ON [DoctorMedicalSpeciality] ([MedicalSpecialityId1]);
GO

CREATE INDEX [IX_Doctors_UserId] ON [Doctors] ([UserId]);
GO

CREATE INDEX [IX_HealthCenterMedicalSpeciality_HealthCenterId1] ON [HealthCenterMedicalSpeciality] ([HealthCenterId1]);
GO

CREATE INDEX [IX_HealthCenterMedicalSpeciality_MedicalSpecialityId1] ON [HealthCenterMedicalSpeciality] ([MedicalSpecialityId1]);
GO

CREATE INDEX [IX_HealthCenterNurses_HealthCenterId1] ON [HealthCenterNurses] ([HealthCenterId1]);
GO

CREATE INDEX [IX_HealthCenterNurses_NurseId1] ON [HealthCenterNurses] ([NurseId1]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [Jobs] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_Managers_UserId] ON [Managers] ([UserId]);
GO

CREATE INDEX [IX_Nurses_UserId] ON [Nurses] ([UserId]);
GO

CREATE INDEX [IX_Patients_UserId] ON [Patients] ([UserId]);
GO

CREATE INDEX [IX_PhoneHealthCenter_HealthCenterId] ON [PhoneHealthCenter] ([HealthCenterId]);
GO

CREATE INDEX [IX_PhoneUser_UserId] ON [PhoneUser] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210622202112_PolyClinicV1-0004', N'5.0.6');
GO

COMMIT;
GO

