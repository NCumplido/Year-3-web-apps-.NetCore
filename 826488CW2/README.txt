Nicholas Cumplido 826488

Web Application Development CW2

1, Please see test/questions for list/overview of this solution.

2, Please see TODO: comments/tag for work to be implemented/finished.

3, Comments:
	
	Seeding does not work, issue with IdentityUser
	Annotations in Controllers: [RequireHttps] tag prevents me from testing

	Upgraded to 2.0.9 to prevent vulnerability of denial of service warned from Github (Still get vulnerability warning)
	Please see: https://github.com/aspnet/Announcements/issues/311
	<PackageReference Include="Microsoft.AspNetCore.All" Version="2.0.9" />

	XSS Implementation needs to be completed, from output:
	Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ValidateAntiforgeryTokenAuthorizationFilter:
	Information: Antiforgery token validation failed. The required antiforgery header value "RequestVerificationToken" is not present.

	Need to link Comments to posts
	Need implement a partial view to show comments with each post