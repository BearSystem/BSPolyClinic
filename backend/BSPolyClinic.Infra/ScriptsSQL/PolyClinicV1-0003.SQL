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

CREATE TABLE [Addresses] (
    [AddressId] int NOT NULL IDENTITY,
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
    [UserId] nvarchar(450) NOT NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([AddressId]),
    CONSTRAINT [FK_Addresses_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id])
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

CREATE TABLE [HealthCenters] (
    [HealthCenterId] int NOT NULL IDENTITY,
    [Title] VARCHAR(120) NULL,
    [Description] VARCHAR(512) NULL,
    [Observation] VARCHAR(512) NULL,
    [AddressId] int NOT NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_HealthCenters] PRIMARY KEY ([HealthCenterId]),
    CONSTRAINT [FK_HealthCenters_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([AddressId]) ON DELETE CASCADE
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

CREATE TABLE [Phones] (
    [PhoneId] int NOT NULL IDENTITY,
    [Number] VARCHAR(100) NULL,
    [Type] int NOT NULL,
    [Observation] VARCHAR(300) NULL,
    [UserId] nvarchar(450) NOT NULL,
    [HealthCenterId] int NOT NULL,
    [CreatedAt] datetime NOT NULL DEFAULT (getdate()),
    [UpdatedAt] datetime NOT NULL,
    CONSTRAINT [PK_Phones] PRIMARY KEY ([PhoneId]),
    CONSTRAINT [FK_Phones_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]),
    CONSTRAINT [FK_Phones_HealthCenters_HealthCenterId] FOREIGN KEY ([HealthCenterId]) REFERENCES [HealthCenters] ([HealthCenterId])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Description', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Jobs]'))
    SET IDENTITY_INSERT [Jobs] ON;
INSERT INTO [Jobs] ([Id], [ConcurrencyStamp], [Description], [Name], [NormalizedName])
VALUES (N'66149471-bfb9-41dd-9718-7ff15e81809d', N'6acf1b88-346e-46c5-a7e3-f88e7e6d76c5', N'Administrador do sistema', N'Administrator', N'ADMINISTRATOR'),
(N'f3227434-302d-4ef4-ac33-23ffc27874f6', N'24bd160c-e7e0-4971-b7c4-c703a2174bc8', N'Gestor(a)', N'Manager', N'MANAGER'),
(N'e3db998a-8b5c-474e-9f63-c1f2e01bf86e', N'c93e5efa-6b19-45f4-8148-bd599881c060', N'Médico(a)', N'Doctor', N'DOCTOR'),
(N'49e2961e-f313-42c8-af32-2e382932a517', N'ee086f51-8f6f-42f2-a268-8f87425e7cde', N'Enfermeiro(a)', N'Nurse', N'NURSE'),
(N'bc97f211-42b0-401b-bcec-c5329b193da3', N'72c5d037-7200-4b89-825b-99459e50ed51', N'Atendente', N'Attendant', N'ATTENDANT'),
(N'21472412-0ca6-4780-9c8f-f3be1af4d2fc', N'bfc77bc1-8ea3-4e36-bbec-29a7e3e1e708', N'Paciente', N'Patient', N'PATIENT');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Description', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Jobs]'))
    SET IDENTITY_INSERT [Jobs] OFF;
GO

CREATE INDEX [IX_Addresses_UserId] ON [Addresses] ([UserId]);
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

CREATE INDEX [IX_HealthCenters_AddressId] ON [HealthCenters] ([AddressId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [Jobs] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_Managers_UserId] ON [Managers] ([UserId]);
GO

CREATE INDEX [IX_Nurses_UserId] ON [Nurses] ([UserId]);
GO

CREATE INDEX [IX_Patients_UserId] ON [Patients] ([UserId]);
GO

CREATE INDEX [IX_Phones_HealthCenterId] ON [Phones] ([HealthCenterId]);
GO

CREATE INDEX [IX_Phones_UserId] ON [Phones] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210622193120_PolyClinicV1-0003', N'5.0.6');
GO

COMMIT;
GO

