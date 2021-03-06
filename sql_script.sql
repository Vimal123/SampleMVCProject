GO
/****** Object:  Table [dbo].[Banks]    Script Date: 07-03-2018 14:51:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banks](
	[Bank_ID] [int] IDENTITY(1,1) NOT NULL,
	[Bank_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Banks] PRIMARY KEY CLUSTERED 
(
	[Bank_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cities]    Script Date: 07-03-2018 14:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[City_ID] [int] IDENTITY(1,1) NOT NULL,
	[City_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[City_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[GetDataForGridWeb]    Script Date: 07-03-2018 14:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetDataForGridWeb]
	@TableName NVARCHAR(MAX)=''
	,@ColumnsName NVARCHAR(MAX)='*'
	,@SortOrder NVARCHAR(50)='ASC'
	,@SortColumn NVARCHAR(50)='RowNumber'
	,@PageNumber INT=0
	,@RecordPerPage INT=10
	,@WhereClause NVARCHAR(MAX)=''

AS
BEGIN
	
	SET NOCOUNT ON;
	IF ISNULL(@ColumnsName,'')=''
		BEGIN
			SET @ColumnsName='*'
		END
	IF ISNULL(@SortOrder,'')=''
		BEGIN
			SET @SortOrder='ASC'
		END
	IF @PageNumber<0
		BEGIN
			SET @PageNumber=-1
		END
	ELSE
		BEGIN
			SET @PageNumber=(@PageNumber/@RecordPerPage)+1
		END
	DECLARE @StartNo INT=0
	DECLARE @EndNo INT=10
	SET @StartNo=(@PageNumber-1)*@RecordPerPage
	SET @EndNo=@PageNumber*@RecordPerPage
	IF ISNULL(@WhereClause,'')!=''
		BEGIN
			SET @WhereClause=' AND '+@WhereClause
		END
	DECLARE @RowClause NVARCHAR(100)='1=1'
	IF @PageNumber>0
		BEGIN
			SET @RowClause+=' AND RowNumber>'+CONVERT(NVARCHAR,@StartNo)+' AND RowNumber<='+CONVERT(NVARCHAR,@EndNo)
		END
	DECLARE @SQL NVARCHAR(MAX)=''
	DECLARE @TotalRows INT =0
	SET @SQL='SELECT @TotalRows=COUNT(1) FROM(SELECT '+@ColumnsName+' FROM '+@TableName+')T WHERE 1=1 '+@WhereClause
	--print @SQL
	EXECUTE sp_executesql @SQL,N'@TotalRows INT out',@TotalRows OUT
	SET @SQL='SELECT '+CONVERT(NVARCHAR,@TotalRows)+' as TotalRows,* FROM (
	SELECT Row_Number() over (order by '+@SortColumn+' '+@SortOrder+') as RowNumber,* FROM(
	SELECT '+@ColumnsName+' FROM '+@TableName+')TMP WHERE 1=1 '+@WhereClause+')T
	WHERE '+@RowClause
	PRINT @SQL
	EXEC(@SQL)
END


GO
