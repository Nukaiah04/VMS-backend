terraform {
  required_providers {
    local = {
      source = "hashicorp/local"
    }
  }
}

provider "local" {}

resource "local_file" "demo" {
  filename = "hello.txt"
  content  = "Terraform is working"
}