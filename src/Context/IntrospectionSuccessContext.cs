using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace IdentityModel.AspNetCore.OAuth2Introspection;

public class IntrospectionSuccessContext : ResultContext<OAuth2IntrospectionOptions>
{
  /// <inheritdoc />
  public IntrospectionSuccessContext(HttpContext context, AuthenticationScheme scheme, OAuth2IntrospectionOptions options) : base(context, scheme, options)
  {
  }
  
  public TokenIntrospectionResponse Response { get; set; }
}