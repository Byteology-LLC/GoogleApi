﻿using GoogleApi.Entities.Common.Extensions;
using GoogleApi.Entities.Maps.StaticMaps.Request.Enums;

namespace GoogleApi.Entities.Maps.StaticMaps.Request;

/// <summary>
/// Customize the presentation of the standard Google map by applying your own styles when using the Google Static Maps API.
/// You can change the visual display of features such as roads, parks, built-up areas, and other points of interest.Change their color or style to emphasize
/// particular content, complement surrounding content on the page, or even hide features completely.
/// Each style declaration may contain the following arguments, separated by pipe characters ("|").
/// https://developers.google.com/maps/documentation/static-maps/styling
/// </summary>
public class MapStyle
{
    /// <summary>
    /// Feature (optional) indicates the features to select for this style modification.
    /// Features include things on the map, like roads, parks, or other points of interest.
    /// If no features is present, the specified style applies to all features.
    /// </summary>
    public virtual StyleFeature Feature { get; set; } = StyleFeature.All;

    /// <summary>
    /// element(optional) indicates the element(s) of the specified feature to select for this style modification.
    /// Elements are characteristics of a feature, such as geometry or labels.
    /// If no element argument is present, the style applies to all elements of the specified feature.
    /// </summary>
    public virtual StyleElement Element { get; set; } = StyleElement.All;

    /// <summary>
    /// A set of style rules (mandatory) to apply to the specified feature(s) and element(s).
    /// The API applies the rules in the order in which they appear in the style declaration.
    /// You can include any number of rules, within the normal URL-length constraints of the Google Static Maps API.
    /// </summary>
    public virtual StyleRule Style { get; set; }

    /// <summary>
    /// Returns a string representation of a <see cref="MapStyle"/>.
    /// </summary>
    /// <returns>The string representation.</returns>
    public override string ToString()
    {
        var style = this.Style?.ToString();

        if (style == null)
        {
            return null!;
        }

        var featureValue = this.Feature.ToEnumMemberString();
        var elementValue = this.Element.ToEnumMemberString();

        return $"feature:{featureValue}|element:{elementValue}|{this.Style}";
    }
}