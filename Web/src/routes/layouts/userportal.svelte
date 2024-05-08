<script lang="ts">
    import { Router, Route } from 'svelte-routing';
    import HomePage from '$pages/UserPortal/Home/Index.svelte';
</script>
<div>
    <Router url="userportal">
        <Route path="/" component={HomePage} />
    </Router>
</div>