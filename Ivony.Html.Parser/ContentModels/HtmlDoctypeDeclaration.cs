﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ivony.Html.Parser.ContentModels
{

  /// <summary>
  /// DOCTYPE 声明节点
  /// </summary>
  public sealed class HtmlDoctypeDeclaration : HtmlContentFragment
  {

    /// <summary>
    /// 创建 HtmlDoctypeDeclaration 对象
    /// </summary>
    /// <param name="info">应当被认为是 HTML 结束标签的 HTML 片段</param>
    public HtmlDoctypeDeclaration( HtmlContentFragment info ) : base( info ) { }

  }
}
