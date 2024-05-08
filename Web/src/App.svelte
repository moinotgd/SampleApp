<script lang="ts">
  import { Router, Route } from "svelte-routing";
  import UserPortalLayout from './routes/layouts/userportal.svelte';
  export let url = "";
</script>
<Router {url}>
  <Route path="/*userportal">
    <UserPortalLayout></UserPortalLayout>
  </Route>
</Router>