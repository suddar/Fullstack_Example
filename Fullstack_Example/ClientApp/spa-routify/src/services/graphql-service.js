import request from "graphql-request";

let url = "https://localhost:5555/graphql/";

export async function query(querySchema) {
  console.log(querySchema);
  return await request(url, querySchema);
}