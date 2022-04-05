/*
 * IX-API
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * LizardAllOf
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-04-05T10:04:03.079+01:00[Europe/London]")
public class LizardAllOf {
  public static final String SERIALIZED_NAME_LOVES_ROCKS = "lovesRocks";
  @SerializedName(SERIALIZED_NAME_LOVES_ROCKS)
  private Boolean lovesRocks;


  public LizardAllOf lovesRocks(Boolean lovesRocks) {
    
    this.lovesRocks = lovesRocks;
    return this;
  }

   /**
   * Get lovesRocks
   * @return lovesRocks
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getLovesRocks() {
    return lovesRocks;
  }


  public void setLovesRocks(Boolean lovesRocks) {
    this.lovesRocks = lovesRocks;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LizardAllOf lizardAllOf = (LizardAllOf) o;
    return Objects.equals(this.lovesRocks, lizardAllOf.lovesRocks);
  }

  @Override
  public int hashCode() {
    return Objects.hash(lovesRocks);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LizardAllOf {\n");
    sb.append("    lovesRocks: ").append(toIndentedString(lovesRocks)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
