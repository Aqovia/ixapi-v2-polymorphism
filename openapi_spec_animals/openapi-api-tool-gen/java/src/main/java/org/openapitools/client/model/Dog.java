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
import org.openapitools.client.model.DogAllOf;
import org.openapitools.client.model.Pet;

/**
 * Dog
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-04-05T10:04:03.079+01:00[Europe/London]")
public class Dog extends Pet {
  public static final String SERIALIZED_NAME_BARK = "bark";
  @SerializedName(SERIALIZED_NAME_BARK)
  private String bark;


  public Dog bark(String bark) {
    
    this.bark = bark;
    return this;
  }

   /**
   * Get bark
   * @return bark
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getBark() {
    return bark;
  }


  public void setBark(String bark) {
    this.bark = bark;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Dog dog = (Dog) o;
    return Objects.equals(this.bark, dog.bark) &&
        super.equals(o);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bark, super.hashCode());
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Dog {\n");
    sb.append("    ").append(toIndentedString(super.toString())).append("\n");
    sb.append("    bark: ").append(toIndentedString(bark)).append("\n");
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
