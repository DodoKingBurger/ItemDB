CREATE TABLE [dbo].[RecordTable] (
    [SerialNumber]  INT           NOT NULL,
    [DecimalNumber] NVARCHAR (50) NOT NULL,
    [NameD]   NVARCHAR (50) NOT NULL,
    [FIO]           NVARCHAR (50) NOT NULL,
    [DataAdd]       DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([SerialNumber] ASC)
);

