# ixapi-v2-polymorphism


## Overview

Root directory has following sub-dirs:
1. `network_services_latest`
   - this contains models generated from a cutdown ix-api-v2-schama.yaml (just network-services hierarchy)
   - contains spec file `network-services-cut-down.yaml`
2. `openapi_spec_animals`
   - this contains models generated from OAS discriminator (all-of) example
   - https://spec.openapis.org/oas/latest.html#fixed-fields-20
   - contains spec file `animals.yaml`

### Generation of models using the spec(.yaml) files

Two generator frameworks/tools are used to generate client models for the previously menbtioned specs
1. Openapi-Tools generator 
   - https://github.com/OpenAPITools/openapi-generator
   - to use this for a specific code gen client
   - `openapi-generator generate -g {client_type} -i {spec_file.yaml} -o {output_directory}`
   - Eg: `openapi-generator generate -g python -i animals.yaml -o python`   
3. SwaggerCodeGen online tool generator
   - https://editor.swagger.io/
   - paste the spec file into the online tool
   - select the client generation from the nav bar
   - download the zip file to observe generated models
