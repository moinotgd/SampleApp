<script lang="ts">
    import { GET } from "$lib/scripts/common";
    let data;

    async function GetUsers() {
        const response = await GET('api/UserPortal/Home/');
        if (!response.Success) {
            console.error(response.Message); // or your alert
            return false;
        }
        data = response.Data;
    }

    GetUsers();
</script>
<div>
    <table>
        <thead>
            <tr>
                <th>Name</th>
            </tr>
        </thead>
        {#if data}
            <tbody>
                {#each data as row}
                    <tr>
                        <td>{row.Name}</td>
                    </tr>
                {/each}
            </tbody>
        {/if}
    </table>
</div>