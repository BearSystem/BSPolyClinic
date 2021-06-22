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

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Description] nvarchar(max) NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [Name_FirstName] nvarchar(max) NULL,
    [Name_LastName] nvarchar(max) NULL,
    [Name_NickName] nvarchar(max) NULL,
    [Emails_Address] nvarchar(max) NULL,
    [Emails_SecundaryAddress] nvarchar(max) NULL,
    [Document_CPF] nvarchar(max) NULL,
    [Document_RG] nvarchar(max) NULL,
    [Document_NumberSUS] nvarchar(max) NULL,
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

CREATE TABLE [MedicalSpecialties] (
    [Id] uniqueidentifier NOT NULL,
    [Title] VARCHAR(512) NULL,
    [Active] BIT NOT NULL,
    [Description] VARCHAR(512) NULL,
    [Observation] VARCHAR(512) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_MedicalSpecialties] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Addresses] (
    [Id] uniqueidentifier NOT NULL,
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
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Addresses_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Administrators] (
    [Id] uniqueidentifier NOT NULL,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Administrators] PRIMARY KEY ([Id]),
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

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
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
    [Id] uniqueidentifier NOT NULL,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Attendants] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Attendants_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Doctors] (
    [Id] uniqueidentifier NOT NULL,
    [Code] VARCHAR(50) NULL,
    [Crm] VARCHAR(200) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Doctors] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Doctors_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Managers] (
    [Id] uniqueidentifier NOT NULL,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Managers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Managers_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Nurses] (
    [Id] uniqueidentifier NOT NULL,
    [Code] VARCHAR(50) NULL,
    [Crm] VARCHAR(150) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Nurses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Nurses_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Patients] (
    [Id] uniqueidentifier NOT NULL,
    [Code] VARCHAR(50) NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Patients] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Patients_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [HealthCenters] (
    [Id] uniqueidentifier NOT NULL,
    [Title] VARCHAR(120) NULL,
    [Description] VARCHAR(512) NULL,
    [Observation] VARCHAR(512) NULL,
    [AddressId] uniqueidentifier NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_HealthCenters] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_HealthCenters_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [DoctorMedicalSpeciality] (
    [Id] uniqueidentifier NOT NULL,
    [DoctorId] uniqueidentifier NOT NULL,
    [MedicalSpecialityId] uniqueidentifier NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_DoctorMedicalSpeciality] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DoctorMedicalSpeciality_Doctors_DoctorId] FOREIGN KEY ([DoctorId]) REFERENCES [Doctors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DoctorMedicalSpeciality_MedicalSpecialties_MedicalSpecialityId] FOREIGN KEY ([MedicalSpecialityId]) REFERENCES [MedicalSpecialties] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [DoctorHealthCenter] (
    [Id] uniqueidentifier NOT NULL,
    [DoctorId] uniqueidentifier NOT NULL,
    [HealthCenterId] uniqueidentifier NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_DoctorHealthCenter] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DoctorHealthCenter_Doctors_DoctorId] FOREIGN KEY ([DoctorId]) REFERENCES [Doctors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DoctorHealthCenter_HealthCenters_HealthCenterId] FOREIGN KEY ([HealthCenterId]) REFERENCES [HealthCenters] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [HealthCenterMedicalSpeciality] (
    [Id] uniqueidentifier NOT NULL,
    [HealthCenterId] uniqueidentifier NOT NULL,
    [MedicalSpecialityId] uniqueidentifier NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_HealthCenterMedicalSpeciality] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_HealthCenterMedicalSpeciality_HealthCenters_HealthCenterId] FOREIGN KEY ([HealthCenterId]) REFERENCES [HealthCenters] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_HealthCenterMedicalSpeciality_MedicalSpecialties_MedicalSpecialityId] FOREIGN KEY ([MedicalSpecialityId]) REFERENCES [MedicalSpecialties] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [HealthCenterNurses] (
    [Id] uniqueidentifier NOT NULL,
    [HealthCenterId] uniqueidentifier NOT NULL,
    [NurseId] uniqueidentifier NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_HealthCenterNurses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_HealthCenterNurses_HealthCenters_HealthCenterId] FOREIGN KEY ([HealthCenterId]) REFERENCES [HealthCenters] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_HealthCenterNurses_Nurses_NurseId] FOREIGN KEY ([NurseId]) REFERENCES [Nurses] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Phones] (
    [Id] uniqueidentifier NOT NULL,
    [Number] VARCHAR(100) NULL,
    [Type] int NOT NULL,
    [Observation] VARCHAR(300) NULL,
    [HealthCenterId] uniqueidentifier NULL,
    [UserId] nvarchar(450) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Phones] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Phones_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Phones_HealthCenters_HealthCenterId] FOREIGN KEY ([HealthCenterId]) REFERENCES [HealthCenters] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Addresses_UserId] ON [Addresses] ([UserId]);
GO

CREATE INDEX [IX_Administrators_UserId] ON [Administrators] ([UserId]);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

CREATE INDEX [IX_Attendants_UserId] ON [Attendants] ([UserId]);
GO

CREATE INDEX [IX_DoctorHealthCenter_DoctorId] ON [DoctorHealthCenter] ([DoctorId]);
GO

CREATE INDEX [IX_DoctorHealthCenter_HealthCenterId] ON [DoctorHealthCenter] ([HealthCenterId]);
GO

CREATE INDEX [IX_DoctorMedicalSpeciality_DoctorId] ON [DoctorMedicalSpeciality] ([DoctorId]);
GO

CREATE INDEX [IX_DoctorMedicalSpeciality_MedicalSpecialityId] ON [DoctorMedicalSpeciality] ([MedicalSpecialityId]);
GO

CREATE INDEX [IX_Doctors_UserId] ON [Doctors] ([UserId]);
GO

CREATE INDEX [IX_HealthCenterMedicalSpeciality_HealthCenterId] ON [HealthCenterMedicalSpeciality] ([HealthCenterId]);
GO

CREATE INDEX [IX_HealthCenterMedicalSpeciality_MedicalSpecialityId] ON [HealthCenterMedicalSpeciality] ([MedicalSpecialityId]);
GO

CREATE INDEX [IX_HealthCenterNurses_HealthCenterId] ON [HealthCenterNurses] ([HealthCenterId]);
GO

CREATE INDEX [IX_HealthCenterNurses_NurseId] ON [HealthCenterNurses] ([NurseId]);
GO

CREATE INDEX [IX_HealthCenters_AddressId] ON [HealthCenters] ([AddressId]);
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
VALUES (N'20210622132648_PolyClinicV1-0001', N'5.0.6');
GO

COMMIT;
GO

