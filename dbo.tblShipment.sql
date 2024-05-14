CREATE TABLE [dbo].[tblShipment] (
    [shipmentid]        INT          IDENTITY (1, 1) NOT NULL,
    [orderid]           INT          NULL,
    [street]            VARCHAR (50) NULL,
    [city]              VARCHAR (50) NULL,
    [postcode]          VARCHAR (15) NULL,
    [delivery_Date]     DATE         NULL,
    [isDeliveryExpress] BIT          NULL,
    CONSTRAINT [PK_tblShipment] PRIMARY KEY CLUSTERED ([shipmentid] ASC)
);

