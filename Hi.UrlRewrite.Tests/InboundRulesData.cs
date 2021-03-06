﻿using Hi.UrlRewrite.Entities.Actions;
using Hi.UrlRewrite.Entities.Conditions;
using Hi.UrlRewrite.Entities.Match;
using Hi.UrlRewrite.Entities.Rules;
using System.Collections.Generic;
using System.Web;

namespace Hi.UrlRewrite.Tests
{
    public class InboundRulesData
    {
        public static List<InboundRule> GetInboundRulesData()
        {
            return new List<InboundRule>()
            {
                new InboundRule()
                {
                    Action = new Redirect()
                    {
                        AppendQueryString = true,
                        HttpCacheability = HttpCacheability.NoCache,
                        Name = "RedirectAction 1",
                        StatusCode = RedirectStatusCode.Permanent,
                        RewriteUrl = "http://www.google.com",
                        StopProcessingOfSubsequentRules = false
                    },
                    Enabled = true,
                    IgnoreCase = true,
                    Name = "Inbound Rule 1",
                    Pattern = "john",
                    Using = Using.ExactMatch,
                    MatchType = MatchType.MatchesThePattern,
                    ConditionLogicalGrouping = LogicalGrouping.MatchAll
                },
                new InboundRule()
                {
                    Action = new Redirect()
                    {
                        AppendQueryString = true,
                        HttpCacheability = HttpCacheability.NoCache,
                        Name = "RedirectAction 1",
                        StatusCode = RedirectStatusCode.Permanent,
                        RewriteUrl = "http://{HTTP_HOST}/article.aspx?id={R:1}&amp;title={R:2}",
                        StopProcessingOfSubsequentRules = false
                    },
                    Enabled = true,
                    IgnoreCase = true,
                    Name = "Inbound Rule 2",
                    Pattern = "^article/([0-9]+)/([_0-9a-z-]+)",
                    Using = Using.RegularExpressions,
                    MatchType = MatchType.MatchesThePattern,
                    ConditionLogicalGrouping = LogicalGrouping.MatchAll
                },
                new InboundRule()
                {
                    Action = new Redirect()
                    {
                        AppendQueryString = true,
                        HttpCacheability = HttpCacheability.NoCache,
                        Name = "RedirectAction 1",
                        StatusCode = RedirectStatusCode.Permanent,
                        RewriteUrl = "http://{HTTP_HOST}/hostreplaced",
                        StopProcessingOfSubsequentRules = false
                    },
                    Enabled = true,
                    IgnoreCase = true,
                    Name = "Inbound Rule 3",
                    Pattern = "^hostreplacement$",
                    Using = Using.RegularExpressions,
                    MatchType = MatchType.MatchesThePattern,
                    ConditionLogicalGrouping = LogicalGrouping.MatchAll
                }
            };
        }
    }
}
